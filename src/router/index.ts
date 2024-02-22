import { createRouter, createWebHistory } from "vue-router"
import HomeView from "../views/HomeView.vue"
import FunctionsView from "../views/FunctionsView.vue"
import FunctionDescriptionView from "../views/FunctionDescriptionView.vue"

const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: [
        {
            path: '/',
            name: 'home',
            component: HomeView
        },
        {
            path: '/Obras',
            name: 'obras',
            component: FunctionsView
        },
        {
            path: '/Obra/:id',
            name: 'obra',
            component: FunctionDescriptionView,
            props: true,
        }
    ]
})

export default router