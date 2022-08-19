import React from 'react';
import { render, screen } from '@testing-library/react';
import ToDoList from './ToDoList';
import { ToDoTask } from '../../api/toDoTasks';

test('renders learn react link', () => {
  const toDoTask1: ToDoTask = {
    id: '1',
    description: 'task pending',
    state: 'Pending'
  };
  const toDoTask2: ToDoTask = {
      id: '1',
      description: 'task completed',
      state: 'Completed'
  };
  render(<ToDoList taskList={[toDoTask1, toDoTask2]}/>);
  
  const textElementPending = screen.getByText(/task pending/i);
  expect(textElementPending).toBeInTheDocument();

  const textElementCompleted = screen.getByText(/task completed/i);
  expect(textElementCompleted).toBeInTheDocument();
});