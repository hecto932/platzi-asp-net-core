using System;

namespace platzi_asp_net_core.Models
{
  public abstract class ObjSchoolBase {
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public virtual string Name { get; set; }

    public ObjSchoolBase () {

    }

    public override string ToString() {
      return $"{Name}, {Id}";
    }
  }
}