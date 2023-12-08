using HR.Domain.Model;

namespace HR.Domain.Utils.CustomFieldUtil;
public interface IFillCustomFieldProps
{
	void FillCustomFieldProps(CustomField customField, CustomFieldDto customFieldDto);
}
