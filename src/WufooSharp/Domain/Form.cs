﻿using System;
using Newtonsoft.Json;

namespace WufooSharp
{
    [JsonObject(MemberSerialization.OptOut)]
    public class Form
    {

        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public string RedirectMessage { get; set; }
        
        public string Url { get; set; }
        
        public string Email { get; set; }
        
        [JsonConverter(typeof(WufooBooleanConverter))]
        public bool IsPublic { get; set; }
        
        public string Language { get; set; }
        
        public int EntryLimit { get; set; }
        
        public string Hash { get; set; }
        
        public Uri LinkFields { get; set; }
        
        public Uri LinkEntries { get; set; }
        
        public Uri LinkEntriesCount { get; set; }

        [JsonConverter(typeof(MySqlDateTimeConverter))]
        public DateTime StartDate { get; set; }

        [JsonConverter(typeof(MySqlDateTimeConverter))]
        public DateTime EndDate { get; set; }

        [JsonConverter(typeof(MySqlDateTimeConverter))]
        public DateTime DateCreated { get; set; }

        [JsonConverter(typeof(MySqlDateTimeConverter))]
        public DateTime DateUpdated { get; set; }

        public int? EntryCountToday { get; set; }

    }
}
