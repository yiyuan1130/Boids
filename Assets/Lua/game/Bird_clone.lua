local Bird = class("Bird")

function Bird:ctor(...)
end

function Bird:Start()
    self.eye = self:createEye()
    self:setupViewPoint()
    self.rotateSpeed = 1000
    self.flySpeed = 2
    -- self:checkSign()
end

function Bird:Update()
    -- self.gameObject.transform:Rotate(Vector3.up, self.rotateSpeed * Time.fixedDeltaTime)
    local dir, hit = self:checkSign()
    
    if hit then
        local angle = Vector3.Angle(dir, self.gameObject.transform.forward)
        local v = Vector3.Dot(dir, self.gameObject.transform.forward)
        local vect = self.gameObject.transform.up
        if v < 0 then
            vect = Vector3(self.gameObject.transform.up.x, self.gameObject.transform.up.y * -1, self.gameObject.transform.up.z)
        else
            vect = self.gameObject.transform.up
        end
        local expectForward = Vector3.Cross(dir, vect) * -1
        expectForward = self.eye.transform:TransformDirection(dir).normalized
        local needRotateAngle = Vector3.Angle(expectForward, self.gameObject.transform.forward)
        local forward = Quaternion.AngleAxis(self.rotateSpeed * Time.fixedDeltaTime, self.gameObject.transform.forward)
        self.gameObject.transform.forward = forward.eulerAngles
        Debug.DrawRay(self.eye.position, self.gameObject.transform.forward * 5, Color.yellow)
    end
    self.gameObject.transform.position = self.gameObject.transform.position + self.gameObject.transform.forward * self.flySpeed * Time.fixedDeltaTime
end

function Bird:OnDestroy()
    
end

function Bird:createEye()
    local eye1 = self.gameObject.transform:Find("Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Neck/Bip001 Head/Bone008")
    local eye2 = self.gameObject.transform:Find("Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Neck/Bip001 Head/Bone008(mirrored)")
    local eye = GameObject("eye").transform
    eye:SetParent(eye1.transform.parent)
    eye.position = (eye1.position + eye2.position) * 0.5
    return eye
end

function Bird:setupViewPoint()
    self.viewPoints = {}
    local viewAngle = 120
    local count = 180
    local zValue = (90 - viewAngle / 2) / 90
    for i = 1, count - 1 do
        local t = i / (count - 1)
        local inc = Mathf.Acos(1.0 - 2.0 * t)
        local z = Mathf.Cos(inc)
        if z > zValue then
            local az = 2.0 * Mathf.PI * 1.618 * i
            local x = Mathf.Sin(inc) * Mathf.Cos(az)
            local y = Mathf.Sin(inc) * Mathf.Sin(az)
            local dir = Vector3(x,y,z).normalized
            table.insert(self.viewPoints, Vector3(x,y,z).normalized)
        end
    end
end

function Bird:checkSign()
    local hitDis = 5
    self.eye.forward = self.gameObject.transform.forward
    local points = {}
    for _, point in pairs(self.viewPoints) do
        local startPos = self.eye.position
        local endPos = self.eye.transform:TransformDirection(point) * hitDis
        Debug.DrawRay(startPos, endPos, Color.red)
        local ray = Ray(startPos, endPos)
        local hit, hitInfo = Physics.Raycast(ray, hitDis, 1 << LayerMask.NameToLayer("Obstacle"))
        if hit then
            table.insert(points, {
                point = hitInfo.point,
                dir = point
            })
        end
    end
    local dir = self.gameObject.transform.forward
    if #points > 0 then
        table.sort(points, function(a, b)
            local disA = Vector3.Distance(a.point, self.eye.position)
            local disB = Vector3.Distance(b.point, self.eye.position)
            return disA > disB
        end)
        dir = points[1].dir
        Debug.DrawRay(self.eye.position, (points[1].point - self.eye.position).normalized * hitDis, Color.green)
    end
    return dir, #points > 0
end

return Bird