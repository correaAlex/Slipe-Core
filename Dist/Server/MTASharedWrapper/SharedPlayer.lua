-- Generated by CSharp.lua Compiler
local System = System
local MultiTheftAuto = MultiTheftAuto
local MTASharedWrapper
System.import(function (out)
  MTASharedWrapper = out.MTASharedWrapper
end)
System.namespace("MTASharedWrapper", function (namespace)
  namespace.class("SharedPlayer", function (namespace)
    local getName, setName, GetFromName, class, __ctor__
    __ctor__ = function (this, mtaElement)
      MTASharedWrapper.Element.__ctor__[2](this, mtaElement)
    end
    getName = function (this)
      return MultiTheftAuto.Shared.GetPlayerName(this.element)
    end
    setName = function (this, value)
      System.throw(System.NotImplementedException())
    end
    GetFromName = function (name)
      return System.cast(class, MTASharedWrapper.ElementManager.getInstance():GetElement(MultiTheftAuto.Shared.GetPlayerFromName(name)))
    end
    class = {
      __inherits__ = function (out)
        return {
          out.MTASharedWrapper.Element
        }
      end,
      getName = getName,
      setName = setName,
      GetFromName = GetFromName,
      __ctor__ = __ctor__
    }
    return class
  end)
end)