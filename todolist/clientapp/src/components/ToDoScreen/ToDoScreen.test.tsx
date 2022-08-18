import React from 'react';
import { render, screen } from '@testing-library/react';
import ToDoScreen from './ToDoScreen';

test('renders learn react link', () => {
  render(<ToDoScreen />);
  const textElement = screen.getByText(/To Do tasks/i);
  expect(textElement).toBeInTheDocument();
});