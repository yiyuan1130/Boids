local Bird = class("Bird")

function Bird:ctor(...)
end

function Bird:Start()
    self.eye = self.gameObject.transform:Find("Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Neck/Bip001 Head/")
    self.rotateSpeed = 100
end

function Bird:Update()
    -- self.gameObject.transform:Rotate(Vector3.up, self.rotateSpeed * Time.fixedDeltaTime)
    self:checkSign()
end

function Bird:OnDestroy()

end

function Bird:checkSign()
    local ray = Ray(self.eye.position, self.eye.position + self.gameObject.transform.forward)
    local hitDis = 5
    local hit, hitInfo = Physics.Raycast(ray, hitDis, 1 << LayerMask.NameToLayer("Obstacle"))
    if hit then
        print(hitInfo)
        -- print("hit -> ", hitInfo.point)
    end
end

return Bird