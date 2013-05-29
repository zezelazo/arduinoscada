using System;

namespace isct.arduinoscada.common.entities {
  public class Entity<T> : IComparable<Entity<T>> {
    public Entity() {
      Creation = DateTime.Now;
      Creator = "sys";
    }

    public T Id { get; set; }
    public string Name { get; set; }

    public DateTime Creation { get; set; }
    public string Creator { get; set; }

    protected bool Equals(Entity<T> entity) {
      if(entity == null) return false;
      return GetType() == entity.GetType() && Id.Equals(entity.Id);
    }

    public override bool Equals(object obj) {
      if(obj == null) return false;
      return ReferenceEquals(this, obj) || Equals(obj as Entity<T>);
    }

    public override int GetHashCode() {
      var result = base.GetHashCode();
      result = 29 * result + (!(Id == null) ? Id.GetHashCode() : 0);
      return result;
    }

    //solo para clases no genericas.
    public virtual object Clone() {
      return MemberwiseClone();
    }

    #region Miembros de IComparable<GenericEntity>

    public virtual int CompareTo(Entity<T> other) {
      return other.Id.GetHashCode().CompareTo(Id.GetHashCode());
    }

    #endregion
  }
}