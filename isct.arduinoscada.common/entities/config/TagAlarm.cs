namespace isct.arduinoscada.common.entities.config {
  public class TagAlarm {
    public TagAlarm() {
      Trigger = EAlarmTrigger.On;
      AlarmType = EAlarmType.Information;
    }
    public object TriggerValue { get; set; }
    public EAlarmTrigger Trigger { get; set; }
    public decimal? DeathBandValue { get; set; }
    public EAlarmType AlarmType { get; set; }
    public string AlarmName { get; set; }
    public string AlarmDescription { get; set; }
    public string AlarmMessage { get; set; }
    public bool LogAlarm { get; set; }
  }
}