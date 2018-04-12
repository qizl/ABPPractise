﻿using Abp.Application.Services;
using SimpleTaskSystem.Task.Dtos;
using SimpleTaskSystem.Tasks.Dtos;

namespace SimpleTaskSystem.SimpleTask
{
    public interface ITaskAppService : IApplicationService
    {
        GetTasksOutput GetTasks(GetTasksInput input);
        void UpdateTask(UpdateTaskInput input);
        void CreateTask(CreateTaskInput input);
    }
}
