﻿using AutoStartConfirm.AutoStarts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace AutoStartConfirm.Converters {
    class CanBeRemovedConverter : IValueConverter {
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
			var autoStart = (AutoStartEntry)value;
			if (autoStart.CanBeRemoved.HasValue) {
				return autoStart.CanBeRemoved.Value;
			}
			Task.Run(() => {
				App.GetInstance().AutoStartService.LoadCanBeRemoved(autoStart);
			});
			return false;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
			throw new NotSupportedException();
		}
	}
}
