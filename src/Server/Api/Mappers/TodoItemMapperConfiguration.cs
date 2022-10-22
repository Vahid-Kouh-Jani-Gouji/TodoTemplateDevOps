using TodoTemplateDevOps.Server.Api.Models.TodoItem;
using TodoTemplateDevOps.Shared.Dtos.TodoItem;

namespace TodoTemplateDevOps.Server.Api.Mappers;

public class TodoItemMapperConfiguration : Profile
{
    public TodoItemMapperConfiguration()
    {
        CreateMap<TodoItem, TodoItemDto>().ReverseMap();
    }
}
