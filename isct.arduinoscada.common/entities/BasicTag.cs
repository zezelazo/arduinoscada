using System;

namespace isct.arduinoscada.common.entities {
  public class TagDef {
    public int Id { get; set; }
    public string Name { get; set; }
    public string TagDir { get; set; }
    public bool CanWrite { get; set; }
    public bool IsDigital { get; set; }
    public bool IsInternal { get; set; }    
  }

  public interface IScaleTag {
    decimal ConvFactor { get; set; }
    EConvertOperator ConvOperatior { get; set; }
  }

  public interface IAlarm {
    decimal AlarmValue { get; set; }
    EAlarmCompareOperator AlarmCompareOperator { get; set; }  
  }

  public class TagExt:IScaleTag, IAlarm {
    public string Description { get; set; }
    public string Label { get; set; }
    public bool CanRaiseAlarm { get; set; }
    public decimal ConvFactor { get; set; }
    public EConvertOperator ConvOperatior { get; set; }
    public decimal AlarmValue { get; set; }
    public EAlarmCompareOperator AlarmCompareOperator { get; set; }
  }

  public enum EAlarmCompareOperator {
    Equal,
    Great,
    Less,
    GreatOrEqual,
    LessOrEqual
  }

  public enum EConvertOperator {
    Sum,
    Substraction,
    Multiplication,
    Division,
    Pow,
    Sqrt
  }

  public class RtTag {
    public int Id { get; set; }
    public object Value { get; set; }
    public object TimeStamp { get; set; }
  }
  public class ArduinoDevice {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string BaseUrl { get; set; }
    public DateTime? LastTimeOnline { get; set; }
  }
}