﻿using AutoStartConfirm.AutoStarts;

namespace AutoStartConfirm.Connectors {
    class Run64Connector : RegistryConnector {

        private readonly Category category = Category.Run64;

        private readonly string basePath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        private readonly string[] subKeys = null;

        private readonly string[] valueNames = null;

        private readonly bool monitorSubkeys = true;

        public override string BasePath {
            get {
                return basePath;
            }
        }

        public override string[] SubKeyNames {
            get {
                return subKeys;
            }
        }

        public override string[] ValueNames {
            get {
                return valueNames;
            }
        }

        public override Category Category {
            get {
                return category;
            }
        }

        public override bool MonitorSubkeys {
            get {
                return monitorSubkeys;
            }
        }
    }
}
