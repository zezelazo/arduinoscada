namespace isct.arduinoscada.common.entities {
  public class TagExt : IScaleTag, IAlarm {
    public TagExt() {
      CanRaiseAlarm = false;
      AlarmValue = 0;
      AlarmCompareOperator = EAlarmCompareOperator.Equal;
      ConvFactor = 0;
      ConvOperator = EConvertOperator.Multiplication;
    }

    public string Description { get; set; }
    public string Label { get; set; }
    public bool CanRaiseAlarm { get; set; }
    public decimal AlarmValue { get; set; }
    public EAlarmCompareOperator AlarmCompareOperator { get; set; }
    public decimal ConvFactor { get; set; }
    public EConvertOperator ConvOperator { get; set; }
  }
}