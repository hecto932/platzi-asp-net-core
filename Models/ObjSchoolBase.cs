using System;

namespace platzi_asp_net_core.Models
{
  public abstract class ObjSchoolBase {
    public string UniqueId { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }

    public ObjSchoolBase () {

    }

    public override string ToString() {
      return $"{Name}, {UniqueId}";
    }
  }
}