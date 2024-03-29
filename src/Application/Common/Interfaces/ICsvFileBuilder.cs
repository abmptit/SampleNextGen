﻿using NextGen.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace NextGen.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
