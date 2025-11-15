using ContentModels = Umbraco.Cms.Web.Common.PublishedModels;

namespace Onatrix.Web.Models.ViewModels;

public class ServiceCardViewModel
{
  public ContentModels.ServiceDetailSection Detail { get; set; } =null!;
  public string? LinkUrl { get; set; } = string.Empty;
}
