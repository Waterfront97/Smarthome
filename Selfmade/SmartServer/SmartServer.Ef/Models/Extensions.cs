﻿using System;
using System.Collections.Generic;
using System.Text;
using SmartServer.Common.Models;

namespace SmartServer.Ef.Models
{
  public static class Extensions
  {
    public static SmartTemperatureClient ConvertToSmartClient(this StoredSmartTemperatureClient storedSmartTemperatureClient)
    {
      if (storedSmartTemperatureClient == null)
      {
        return null;
      }
      SmartTemperatureClient smartTemperatureClient = new SmartTemperatureClient{ChipId = storedSmartTemperatureClient.ChipId};
      smartTemperatureClient.Temperature = storedSmartTemperatureClient.Temperature;
      smartTemperatureClient.Humidity = storedSmartTemperatureClient.Humidity;
      smartTemperatureClient.LastDataUpdate = storedSmartTemperatureClient.LastDataUpdate;
      smartTemperatureClient.Name = storedSmartTemperatureClient.Name;
      return smartTemperatureClient;
    }
  }
}
