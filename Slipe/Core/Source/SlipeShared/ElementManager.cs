﻿using Slipe.MTADefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Slipe.Shared
{
    /// <summary>
    /// Class that manages MTAElement functionality and 
    /// </summary>
    public class ElementManager
    {
        private static ElementManager instance;

        /// <summary>
        /// Get the singleton instance of this class
        /// </summary>
        public static ElementManager Instance
        {
            get
            {
                if (instance == null)
                {
                    throw new Exception("ElementManager was not defined. Please double check you have a call to `new ElementManager(new ElementHelper());` in your main");
                }
                return instance;
            }
        }

        private IElementHelper elementHelper;

        private Element root;

        /// <summary>
        /// Returns the root MTA element
        /// </summary>
        public Element Root { get { return root; } }

        private Dictionary<System.Object, Element> elements;

        /// <summary>
        /// Creates the ElementManager given an IElementHelper class that maps MTA elements to classes
        /// </summary>
        /// <param name="helper"></param>
        public ElementManager(IElementHelper helper)
        {
            this.elementHelper = helper;
            instance = this;
            elements = new Dictionary<System.Object, Element>();
            root = new Element(MTAShared.GetRootElement());
        }

        /// <summary>
        /// Registers an element class
        /// </summary>
        public void RegisterElement(Element element)
        {
            Console.WriteLine("Registring element");
            elements.Add(element.MTAElement, element);
        }

        /// <summary>
        /// Gets an element class instance given a certain MTA element
        /// </summary>
        public Element GetElement(MTAElement element)
        {
            if (element == null)
            {
                return null;
            }
            if (!this.elements.ContainsKey(element))
            {
                try
                {
                    string mtaElementType = MTAShared.GetElementType(element);
                    Element wrapperElement = elementHelper.InstantiateElement(mtaElementType, element);
                    return wrapperElement;
                } catch(Exception)
                {
                    return null;
                }
            }
            return this.elements[element];
        }

        protected internal void AddEventHandler(Element element, string eventName, bool propagated = true, string priorty = "normal")
        {
            MTAShared.AddEventHandler(eventName, element.MTAElement, "Slipe.Shared.ElementManager.HandleEvent", propagated, priorty);
        }

        /// <summary>
        /// Handles an event when it's triggered on a specific MTA element
        /// </summary>
        public static void HandleEvent(string eventString, MTAElement source, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            Element element = Instance.GetElement(source);
            if (element == null)
            {
                // if the resource is not aware of the referenced element's existance have the root element handle it instead
                // this is particularly useful for playerJoin, since the player element will not exist before that yet
                Element.Root.HandleEvent(eventString, source, p1, p2, p3, p4, p5, p6, p7, p8);
                return;
            }
            element.HandleEvent(eventString, source, p1, p2, p3, p4, p5, p6, p7, p8);
        }

    }
}