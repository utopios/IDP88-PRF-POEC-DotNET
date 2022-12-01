import { VISIBILITY_FILTER } from '../constants/Visibility'
import visibilityFilter from '../reducers/visibilityFilter';

export const getTodosState = store => store.todos;

export const getTodosList = store =>
    getTodosState(store) ? getTodosState(store).allIds : [];

export const getTodoById = (store, id) =>
    getTodosState(store) ? { ...getTodosState(store).byIds[id], id } : {};

export const getTodos = store =>
    getTodosList(store).map(id => getTodoById(store, id));

export const getTodosByVisibilityFilter = (store, visibilityFilter) => {
    const allTodos = getTodos(store);
    switch (visibilityFilter) {
        case VISIBILITY_FILTER.COMPLETED:
            return allTodos.filter(todo => todo.completed)
        case VISIBILITY_FILTER.INCOMPLETE:
            return allTodos.filter(todo => !todo.completed)
        case VISIBILITY_FILTER.ALL:
        default:
            return allTodos;
    }
}
