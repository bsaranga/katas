import React from 'react';
import { render, screen } from '@testing-library/react';
import App from './App';


test('Renders Hello World To Screen', () => {
  render(<App />);
  const divElement = screen.getByTestId('helloworld') as HTMLDivElement;
  expect(divElement.innerHTML).toBe('Hello World');
});