-- Generated by CSharp.lua Compiler
local System = System
local MultiTheftAuto = MultiTheftAuto
local ArrayString = System.Array(System.String)
local MTAClientWrapperEnums
local MTASharedWrapper
System.import(function (out)
  MTAClientWrapperEnums = MTAClientWrapper.Enums
  MTASharedWrapper = out.MTASharedWrapper
end)
System.namespace("MTAClientWrapper", function (namespace)
  namespace.class("Browser", function (namespace)
    local getSettings, IsDomainBlocked, RequestDomains, RequestDomain, HandleDomainRequest, getCanNavigateBack, getCanNavigateForward, getTitle, 
    getUrl, getIsLoading, getIsFocused, setVolume, setRenderingPaused, setDevTools, ReloadPage, LoadUrl, 
    Focus, GetProperty, InjectMouseDown, InjectMouseUp, InjectMouseMove, InjectMouseWheel, Resize, ExecuteJavascript, 
    ExecuteJavascript1, HandleEvent, class, __ctor1__, __ctor2__
    __ctor1__ = function (this, width, height, isLocal, transparent)
      System.base(this).__ctor__[1](this)
      this.element = MultiTheftAuto.Client.CreateBrowser(width, height, isLocal, transparent)
      MTASharedWrapper.ElementManager.getInstance():RegisterElement(this)
    end
    __ctor2__ = function (this, element)
      System.base(this).__ctor__[1](this)
      this.element = element
      MTASharedWrapper.ElementManager.getInstance():RegisterElement(this)
    end
    getSettings = function ()
      return MultiTheftAuto.Client.GetBrowserSettings()
    end
    IsDomainBlocked = function (domain, isURL)
      return MultiTheftAuto.Client.IsBrowserDomainBlocked(domain, isURL)
    end
    RequestDomains = function (domains, isURL)
      return MultiTheftAuto.Client.RequestBrowserDomains(domains, isURL, HandleDomainRequest)
    end
    RequestDomain = function (domain, isURL)
      return RequestDomains(ArrayString(domain), isURL)
    end
    HandleDomainRequest = function (wasAccepted, domains)
      do
        local i = 0
        while i < #domains do
          local domain = domains:get(i)
          if wasAccepted then
            local default = class.OnDomainRequestAccepted
            if default ~= nil then
              default(domain)
            end
          else
            local extern = class.OnDomainRequestDenied
            if extern ~= nil then
              extern(domain)
            end
          end
          i = i + 1
        end
      end
    end
    getCanNavigateBack = function (this)
      return MultiTheftAuto.Client.CanBrowserNavigateBack(this.element)
    end
    getCanNavigateForward = function (this)
      return MultiTheftAuto.Client.CanBrowserNavigateForward(this.element)
    end
    getTitle = function (this)
      return MultiTheftAuto.Client.GetBrowserTitle(this.element)
    end
    getUrl = function (this)
      return MultiTheftAuto.Client.GetBrowserURL(this.element)
    end
    getIsLoading = function (this)
      return MultiTheftAuto.Client.IsBrowserLoading(this.element)
    end
    getIsFocused = function (this)
      return MultiTheftAuto.Client.IsBrowserFocused(this.element)
    end
    setVolume = function (this, value)
      MultiTheftAuto.Client.SetBrowserVolume(this.element, value)
    end
    setRenderingPaused = function (this, value)
      MultiTheftAuto.Client.SetBrowserRenderingPaused(this.element, value)
    end
    setDevTools = function (this, value)
      MultiTheftAuto.Client.ToggleBrowserDevTools(this.element, value)
    end
    ReloadPage = function (this)
      return MultiTheftAuto.Client.ReloadBrowserPage(this.element)
    end
    LoadUrl = function (this, url, postData, urlEncoded)
      return MultiTheftAuto.Client.LoadBrowserURL(this.element, url, postData, urlEncoded)
    end
    Focus = function (this)
      return MultiTheftAuto.Client.FocusBrowser(this.element)
    end
    GetProperty = function (this, key)
      return MultiTheftAuto.Client.GetBrowserProperty(this.element, key)
    end
    InjectMouseDown = function (this, mouseButton)
      return MultiTheftAuto.Client.InjectBrowserMouseDown(this.element, mouseButton:ToEnumString(MTAClientWrapperEnums.MouseButton))
    end
    InjectMouseUp = function (this, mouseButton)
      return MultiTheftAuto.Client.InjectBrowserMouseUp(this.element, mouseButton:ToEnumString(MTAClientWrapperEnums.MouseButton))
    end
    InjectMouseMove = function (this, x, y)
      return MultiTheftAuto.Client.InjectBrowserMouseMove(this.element, x, y)
    end
    InjectMouseWheel = function (this, vertical, horizontal)
      return MultiTheftAuto.Client.InjectBrowserMouseWheel(this.element, vertical, horizontal)
    end
    Resize = function (this, x, y)
      return MultiTheftAuto.Client.ResizeBrowser(this.element, x, y)
    end
    ExecuteJavascript = function (this, javascript)
      System.Console.WriteLine("Executing " .. javascript)
      return MultiTheftAuto.Client.ExecuteBrowserJavascript(this.element, javascript)
    end
    ExecuteJavascript1 = function (this, function_, arguments)
      local javascriptString = function_ .. "("

      for _, argument in System.each(arguments) do
        javascriptString = javascriptString .. (argument:ToString() .. ", ")
      end
      javascriptString = javascriptString:Substring(0, #javascriptString - 2)

      javascriptString = javascriptString .. ")"
      return ExecuteJavascript(this, javascriptString)
    end
    HandleEvent = function (this, eventName, element, p1, p2, p3, p4, p5, p6, p7, p8)
      repeat
        local default = eventName
        if default == "onClientBrowserCreated" then
          local extern = this.OnCreated
          if extern ~= nil then
            extern()
          end
          break
        elseif default == "onClientBrowserCursorChange" then
          local ref = this.OnCursorChange
          if ref ~= nil then
            ref(System.cast(System.Int32, p1))
          end
          break
        elseif default == "onClientBrowserDocumentReady" then
          local out = this.OnDocumentReady
          if out ~= nil then
            out(System.cast(System.String, p1))
          end
          break
        elseif default == "onClientBrowserInputFocusChanged" then
          local try = this.OnInputFocusChange
          if try ~= nil then
            try(System.cast(System.Boolean, p1))
          end
          break
        elseif default == "onClientBrowserLoadingFailed" then
          local case = this.OnLoadFail
          if case ~= nil then
            case(System.cast(System.String, p1), System.cast(System.Int32, p2), System.cast(System.String, p3))
          end
          break
        elseif default == "onClientBrowserLoadingStart" then
          local void = this.OnLoadStart
          if void ~= nil then
            void(System.cast(System.String, p1))
          end
          break
        elseif default == "onClientBrowserNavigate" then
          local byte = this.OnNavigate
          if byte ~= nil then
            byte(System.cast(System.String, p1), System.cast(System.Boolean, p2))
          end
          break
        elseif default == "onClientBrowserPopup" then
          local char = this.OnPopup
          if char ~= nil then
            char(System.cast(System.String, p1), System.cast(System.String, p2), System.cast(System.Boolean, p3))
          end
          break
        elseif default == "onClientBrowserResourceBlocked" then
          local uint = this.OnResourceBlocked
          if uint ~= nil then
            uint(System.cast(System.String, p1), System.cast(System.String, p2), System.cast(System.Int32, p3))
          end
          break
        elseif default == "onClientBrowserTooltip" then
          local lock = this.OnTooltip
          if lock ~= nil then
            lock(System.cast(System.String, p1))
          end
          break
        end
      until 1
    end
    class = {
      __inherits__ = function (out)
        return {
          out.MTASharedWrapper.Element
        }
      end,
      getSettings = getSettings,
      IsDomainBlocked = IsDomainBlocked,
      RequestDomains = RequestDomains,
      RequestDomain = RequestDomain,
      HandleDomainRequest = HandleDomainRequest,
      getCanNavigateBack = getCanNavigateBack,
      getCanNavigateForward = getCanNavigateForward,
      getTitle = getTitle,
      getUrl = getUrl,
      getIsLoading = getIsLoading,
      getIsFocused = getIsFocused,
      setVolume = setVolume,
      setRenderingPaused = setRenderingPaused,
      setDevTools = setDevTools,
      ReloadPage = ReloadPage,
      LoadUrl = LoadUrl,
      Focus = Focus,
      GetProperty = GetProperty,
      InjectMouseDown = InjectMouseDown,
      InjectMouseUp = InjectMouseUp,
      InjectMouseMove = InjectMouseMove,
      InjectMouseWheel = InjectMouseWheel,
      Resize = Resize,
      ExecuteJavascript = ExecuteJavascript,
      ExecuteJavascript1 = ExecuteJavascript1,
      HandleEvent = HandleEvent,
      __ctor__ = {
        __ctor1__,
        __ctor2__
      }
    }
    return class
  end)
end)