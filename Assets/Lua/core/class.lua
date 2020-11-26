class = function(name, super)
    local cls = {}
    cls._cls_name = name
    -- if super then
    --     setmetatable(t, {__index = super})
    --     t._base = super
    -- end
    cls.new = function(...)
        local clsIns = {}
        setmetatable(clsIns, {__index = cls})
        if clsIns.ctor then
            clsIns:ctor(...)
        end
        return clsIns
    end
    return cls
end