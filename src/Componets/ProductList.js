import React from 'react';
import ProductItem from './ProductItem'; // Importa el componente ProductItem que haremos a continuación

const ProductList = () => {
  // Lista de productos (luego se puede hacer dinámico)
  const products = [
    { id: 1, name: 'Producto 1', price: 100 },
    { id: 2, name: 'Producto 2', price: 200 },
    { id: 3, name: 'Producto 3', price: 300 },
  ];

  return (
    <div>
      <h2>Lista de Productos</h2>
      <div>
        {products.map((product) => (
          <ProductItem key={product.id} product={product} />
        ))}
      </div>
    </div>
  );
};

export default ProductList;
