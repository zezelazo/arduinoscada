namespace isct.arduinoscada.common.entities {
  public interface IScaleTag {
    decimal ConvFactor { get; set; }
    EConvertOperator ConvOperator { get; set; }
  }
}