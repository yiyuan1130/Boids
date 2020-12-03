local Bird = class("Bird")

function Bird:ctor(controller)
    self.controller = controller
    self.velocity = Vector3(0, 0, 1)
end

function Bird:Start()
    self.velocity = self.gameObject.transform.forward * 6
    self.maxVelocity = 7
    self.minVelocity = 5
    self.target = GameObject.Find("target")
end

function Bird:Update()
    self.birds = self.controller.birdIns
    self:findBirds()
    self:move()
    local v1 = self:separation()
    local v2 = self:alignment()
    local v3 = self:cohesion()
    local v4 = self:external()
    -- self.velocity = (v1 + v2 + v3) / 3
    self.velocity = (v1 + v2 + v3 + v4) / 4
end

function Bird:OnDestroy()
    
end

function Bird:move()
    if self.velocity.magnitude > self.maxVelocity then
        self.velocity = self.velocity.normalized * self.maxVelocity
    end
    if self.velocity.magnitude < self.minVelocity then
        self.velocity = self.velocity.normalized * self.minVelocity
    end
    self.gameObject.transform.position = self.gameObject.transform.position + self.velocity * Time.deltaTime
    self.gameObject.transform.rotation = Quaternion.LookRotation(self.velocity)
end

function Bird:findBirds()
    local radius = 10
    self.foundedBirds = {}
    for _, bird in pairs(self.birds) do
        if self ~= bird then
            if Vector3.Distance(bird.gameObject.transform.position, self.gameObject.transform.position) < radius then
                table.insert(self.foundedBirds, bird)
            end
        end
    end
end

-- 分离
function Bird:separation()
    local radius = 2
    local force = Vector3.zero
    local found = 0
    local forceScale = 15
    for i = 1, #self.foundedBirds do
        if Vector3.Distance(self.gameObject.transform.position, self.foundedBirds[i].gameObject.transform.position) < radius then
            force = force + (self.gameObject.transform.position - self.foundedBirds[i].gameObject.transform.position)
            found = found + 1
        end
    end
    if found > 0 then
        force = force / found * forceScale
        return Vector3.Lerp(self.velocity, force, Time.deltaTime)
    end
    return self.velocity
end

-- 一致性
function Bird:alignment()
    local average = Vector3.zero
    local found = 0
    if self.foundedBirds and #self.foundedBirds > 0 then
        for i = 1, #self.foundedBirds do
            average = average + self.foundedBirds[i].velocity
            found = found + 1
        end
    end
    if found > 0 then
        average = average / found
        return Vector3.Lerp(self.velocity, average, Time.deltaTime)
    end
    return self.velocity
end

-- 凝聚力
function Bird:cohesion()
    local radius = 5
    local averagePos = Vector3.zero
    local found = 0
    for i = 1, #self.foundedBirds do
        if Vector3.Distance(self.gameObject.transform.position, self.foundedBirds[i].gameObject.transform.position) > radius then
            averagePos = averagePos + self.foundedBirds[i].gameObject.transform.position
            found = found + 1
        end
    end
    if found > 0 then
        averagePos = averagePos / found
        local targetVelocity = (averagePos - self.gameObject.transform.position).normalized * self.velocity.magnitude
        return Vector3.Lerp(self.velocity, targetVelocity, Time.deltaTime)
    end
    return self.velocity
end

function Bird:external()
    local ratio = 0.2
    local vect = (self.target.transform.position - self.gameObject.transform.position)
    local average = Vector3.Lerp(self.velocity, vect, Time.deltaTime) * ratio
    return average
    -- return Vector3.zero
end

function Bird:moveTest()
    -- self.velocity = self.velocity + self.gameObject.transform.right
end

return Bird