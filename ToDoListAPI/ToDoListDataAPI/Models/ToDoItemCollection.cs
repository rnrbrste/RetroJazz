﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using RetroAPI.Models;

namespace RetroAPI.Models
{
    public static partial class ToDoItemCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<ToDoItem> DeserializeJson(JToken inputObject)
        {
            IList<ToDoItem> deserializedObject = new List<ToDoItem>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                ToDoItem toDoItem = new ToDoItem();
                toDoItem.DeserializeJson(iListValue);
                deserializedObject.Add(toDoItem);
            }
            return deserializedObject;
        }
    }
}