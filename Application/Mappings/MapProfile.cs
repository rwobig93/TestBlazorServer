namespace Application.Mappings;

public class BaseMapProfile : Profile
{
    // This class is a workaround for automapper, using typeof(Program) doesn't load from dependencies
    //   and since the mapping profiles are in this project typeof(Profile) or typeof(Assembly.GetExecutingAssembly)
    //   won't work either, creating this base class in this project fixes the issue
}