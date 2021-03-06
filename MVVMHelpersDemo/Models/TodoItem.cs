﻿using System;
using Microsoft.WindowsAzure.MobileServices;

namespace MVVMHelpersDemo.Models
{
    public class TodoItem
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public bool Complete { get; set; }
		[Version]
		public string AzureVersion { get; set; }
    }
}
