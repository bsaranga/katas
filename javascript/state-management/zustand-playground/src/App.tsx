import React from 'react';
import useStore from './store';

function App() {
  const bears = useStore((state) => state.bears);
  const increasePopulation = useStore((state) => state.increasePopulation);
  const removeAllBears = useStore((state) => state.removeAllBears);
  
  return (
    <>
      <div data-testid="helloworld">Hello World</div>
      <div>There are {bears} bears in the forest.</div>
      <button onClick={increasePopulation}>Increase Bears</button>
      <button onClick={removeAllBears}>Reset Bears</button>
    </>
  );
}

export default App;
