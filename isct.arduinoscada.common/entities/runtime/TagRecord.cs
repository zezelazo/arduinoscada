namespace isct.arduinoscada.common.entities.runtime {
  public abstract class TagRecord<TType> : Entity<long> {
    protected TagRecord() {
      Quality = ETagQuality.Unknow;
    }

    public long TagDefinitionId { get; set; }
    public TType Value { get; set; }
    public ETagQuality Quality { get; set; }
  }
}