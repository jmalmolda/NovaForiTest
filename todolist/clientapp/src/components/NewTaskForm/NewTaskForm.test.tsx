import { render, screen } from '@testing-library/react'
import NewTaskForm from './NewTaskForm'

test('renders description input', () => {
  render(<NewTaskForm onNewTask={() => {}}/>)
  
  const textElementPending = screen.queryByPlaceholderText(/Add a new Task/i)
  expect(textElementPending).toBeInTheDocument()
})

test('renders add task button', () => {
  render(<NewTaskForm onNewTask={() => {}}/>)
  
  const buttonElement = screen.queryByText(/Add/i)
  expect(buttonElement).toBeInTheDocument()
})