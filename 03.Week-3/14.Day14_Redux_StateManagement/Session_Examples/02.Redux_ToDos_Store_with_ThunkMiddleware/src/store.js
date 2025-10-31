// Store Configuration (store.js)
import { thunk } from 'redux-thunk';
import { todosReducer } from './todosReducer';
import { applyMiddleware, configureStore } from '@reduxjs/toolkit';


// without thunk
export const appStore = configureStore({ reducer : todosReducer});


// with thunk
// export const appStore = configureStore({ reducer: todosReducer}, applyMiddleware(thunk));