local Bird = class("Bird")

function Bird:ctor(...)
end

function Bird:Start()
    self.eye = self.gameObject.transform:Find("Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Neck/Bip001 Head")
    self.rotateSpeed = 100
end

function Bird:Update()
    -- self.gameObject.transform:Rotate(Vector3.up, self.rotateSpeed * Time.fixedDeltaTime)
    self:checkSign()
end

function Bird:OnDestroy()

end

function Bird:checkSign()
    local hitDis = 5
    local startPos = self.eye.position
    local endPos = self.gameObject.transform:TransformDirection(Vector3.forward) * hitDis
    -- local ray = Ray(startPos, endPos)
    local hit, hitInfo = Physics.Raycast(startPos, endPos, hitDis, 1 << LayerMask.NameToLayer("Obstacle"))
    print(hit, hitInfo)
    Debug.DrawRay(startPos, endPos, Color.red)
end

return Bird