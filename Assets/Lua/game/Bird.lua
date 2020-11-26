local Bird = class("Bird")

function Bird:ctor(...)
end

function Bird:Start()
    self.rotateSpeed = 100
end

function Bird:Update()
    self.gameObject.transform:Rotate(Vector3.up, self.rotateSpeed * Time.fixedDeltaTime)
end

function Bird:OnDestroy()

end

return Bird