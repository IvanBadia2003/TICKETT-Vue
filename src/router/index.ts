import { createRouter, createWebHistory } from "vue-router"
import AboutView from "../views/AboutView.vue"
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
            path: '/about',
            name: 'about',
            component: AboutView
        },
        {
            path: '/functions',
            name: 'functions',
            component: FunctionsView
        },
        {
            path: '/function/:id',
            name: 'function',
            component: FunctionDescriptionView,
            props: true,
        }
    ]
})

export default router