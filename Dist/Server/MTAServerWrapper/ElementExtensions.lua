-- Generated by CSharp.lua Compiler
local System = System
local MultiTheftAuto = MultiTheftAuto
local MTASharedWrapper
System.import(function (out)
  MTASharedWrapper = out.MTASharedWrapper
end)
System.namespace("MTAServerWrapper", function (namespace)
  namespace.class("ElementExtensions", function (namespace)
    local SetVisibleTo, ClearVisibleTo, IsVisibleTo, Clone, GetZoneName, GetSyncer, SetSyncer
    SetVisibleTo = function (source, target, visible)
      return MultiTheftAuto.Server.SetElementVisibleTo(source:getMTAElement(), target:getMTAElement(), visible)
    end
    ClearVisibleTo = function (source)
      return MultiTheftAuto.Server.ClearElementVisibleTo(source:getMTAElement())
    end
    IsVisibleTo = function (source, target)
      return MultiTheftAuto.Server.IsElementVisibleTo(source:getMTAElement(), target:getMTAElement())
    end
    Clone = function (source, position)
      local mtaElement = MultiTheftAuto.Server.CloneElement(source:getMTAElement(), position.X, position.Y, position.Z, false)
      --TODO: Return new element of proper type
      return System.new(MTASharedWrapper.Element, 2, mtaElement)
    end
    GetZoneName = function (source, citiesOnly)
      return MultiTheftAuto.Server.GetElementZoneName(source:getMTAElement(), citiesOnly)
    end
    GetSyncer = function (source)
      return MTASharedWrapper.ElementManager.getInstance():GetElement(MultiTheftAuto.Server.GetElementSyncer(source:getMTAElement()))
    end
    SetSyncer = function (source, target)
      return MultiTheftAuto.Server.SetElementSyncer(source:getMTAElement(), target:getMTAElement())
    end
    return {
      SetVisibleTo = SetVisibleTo,
      ClearVisibleTo = ClearVisibleTo,
      IsVisibleTo = IsVisibleTo,
      Clone = Clone,
      GetZoneName = GetZoneName,
      GetSyncer = GetSyncer,
      SetSyncer = SetSyncer
    }
  end)
end)