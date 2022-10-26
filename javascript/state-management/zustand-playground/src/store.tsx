import create from "zustand";
import { devtools } from 'zustand/middleware'

type State = {
    bears: number,
    increasePopulation: () => void,
    removeAllBears: () => void
}

const useStore = create<State>()(
    devtools((set) => ({
            bears: 0,
            increasePopulation: () => set((state: State) => ({ ...state, bears: state.bears + 1 })),
            removeAllBears: () => set({ bears: 0 })
        })
    )
);

export default useStore;