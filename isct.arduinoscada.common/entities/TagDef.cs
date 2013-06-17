namespace isct.arduinoscada.common.entities {
  public class TagDef {
    public TagDef() {
      CanWrite = false;
      IsDigital = true;
      IsInternal = true;
      ExtraDetails=new TagExt();
    }

    public long Id { get; set; }
    public string Name { get; set; }
    public string TagDir { get; set; }
    public bool CanWrite { get; set; }
    public bool IsDigital { get; set; }
    public bool IsInternal { get; set; }
    public TagExt ExtraDetails { get; set; }
  }
}