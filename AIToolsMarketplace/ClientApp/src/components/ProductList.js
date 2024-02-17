// ClientApp/src/components/ProductList.js
import React, { useEffect, useState } from 'react';
import axios from 'axios';

function ProductList() {
    const [products, setProducts] = useState([]);

    useEffect(() => {
        // Adjust the endpoint as necessary
        axios.get('api/products')
            .then(response => {
                setProducts(response.data);
            })
            .catch(error => console.log('Error fetching products:', error));
    }, []);

    return (
        <div>
            <h2>Products</h2>
            <ul>
                {products.map(product => (
                    <li key={product.productId}>{product.name} - ${product.price}</li>
                ))}
            </ul>
        </div>
    );
}

export default ProductList;
