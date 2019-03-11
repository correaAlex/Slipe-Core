-- Generated by CSharp.lua Compiler
local System = System
System.namespace("MTAServerWrapper", function (namespace)
  namespace.class("Vehicle", function (namespace)
    local HandleEvent, __ctor1__, __ctor2__
    __ctor1__ = function (this, model, position)
      System.base(this).__ctor__[2](this, model, position:__clone__())
    end
    __ctor2__ = function (this, model, position, rotation, numberplate, variant1, variant2)
      System.base(this).__ctor__[1](this, model, position:__clone__(), rotation:__clone__(), numberplate, variant1, variant2)
    end
    HandleEvent = function (this, eventName, element, p1, p2, p3, p4, p5, p6, p7, p8)
      repeat
        local default = eventName
        if default == "onVehicleDamage" then
          local extern = this.OnDamage
          if extern ~= nil then
            extern(System.cast(System.Single, p1))
          end
          break
        end
      until 1
    end
    return {
      __inherits__ = function (out)
        return {
          out.MTASharedWrapper.SharedVehicle
        }
      end,
      HandleEvent = HandleEvent,
      __ctor__ = {
        __ctor1__,
        __ctor2__
      }
    }
  end)
end)