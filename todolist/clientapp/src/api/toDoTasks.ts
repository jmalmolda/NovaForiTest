import config from "../config"


export interface ToDoTask {
    id?: string
    description: string
    state?: 'Pending' | 'Completed'
}

export const fetchAllTasks = async (): Promise<ToDoTask[]> => {
    const response = await fetch(`${config.api.baseUrl}/api/ToDoTasks`, {
            method: 'GET',
            headers: {'Content-Type': 'application/json'}
        })
    return response.json()
}