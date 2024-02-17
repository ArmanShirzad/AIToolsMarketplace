import axios from 'axios';

const API_BASE_URL = 'http://localhost:44491/api'; // Adjust this to your backend API URL

export const fetchProducts = () => {
    return axios.get(`${API_BASE_URL}/products`);
};

export const loginUser = (credentials) => {
    return axios.post(`${API_BASE_URL}/users/login`, credentials);
};
