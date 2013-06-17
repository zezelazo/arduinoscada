namespace isct.arduinoscada.common.entities {
  public interface IAlarm {
    decimal AlarmValue { get; set; }
    EAlarmCompareOperator AlarmCompareOperator { get; set; }
  }
}