﻿using AutoStartConfirm.Models;
using Microsoft.Win32;

namespace AutoStartConfirm.Connectors.Registry {
    public class ActiveSetup32Connector : RegistryConnector, IActiveSetup32Connector
    {

        private readonly Category category = Category.ActiveSetup32;

        private readonly string basePath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Active Setup\Installed Components";

        private readonly string[] subKeys = null;

        private readonly string[] valueNames = null;

        public override string DisableBasePath
        {
            get
            {
                return null;
            }
        }

        protected override bool GetIsAutoStartEntry(RegistryKey currentKey, string valueName, int level)
        {
            return level == 1 && valueName == "StubPath";
        }

        private readonly bool monitorSubkeys = true;

        public override string BasePath
        {
            get
            {
                return basePath;
            }
        }

        public override string[] SubKeyNames
        {
            get
            {
                return subKeys;
            }
        }

        public override string[] ValueNames
        {
            get
            {
                return valueNames;
            }
        }

        public override Category Category
        {
            get
            {
                return category;
            }
        }

        public override bool MonitorSubkeys
        {
            get
            {
                return monitorSubkeys;
            }
        }
    }
}
