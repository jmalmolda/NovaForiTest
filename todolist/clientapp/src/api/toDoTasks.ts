import config from "../config"

export enum State {
    Pending = 0,
    Completed = 1,
  }

export interface ToDoTask {
    id?: string
    description: string
    state?: State
}

export const fetchAllTasks = async (): Promise<ToDoTask[]> => {
    const response = await fetch(`${config.api.baseUrl}/api/ToDoTasks`, {
            method: 'GET',
            headers: {'Content-Type': 'application/json'}
        })
    return response.json()
}

export const createNewTask = async (description: string): Promise<ToDoTask> => {
    const toDoTask: ToDoTask = {
        description: description,
        state: State.Pending
    };
    const response = await fetch(`https://localhost:7042/api/ToDoTasks`, {
        method: 'POST',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify(toDoTask)
      })
    return await response.json();
}