/* globals module */

"use strict";

function solve() {
    class Product {
        constructor(productType, name, price) {
            this.productType = productType;
            this.name = name;
            this.price = price;
        }

        get productType() {
            return this._productType;
        }
        set productType(value) {

            this._productType = value;
        }

        get name() {
            return this._name;
        }
        set name(value) {

            this._name = value;
        }

        get price() {
            return this._price;
        }
        set price(value) {

            this._price = value;
        }
    }

    class ShoppingCart {
        constructor() {
            this._products = [];
        }

        get products() {
            return this._products;
        }

        add(product) {
            if (product instanceof Product) {
                this._products.push(product);
            }

            return this;
        }

        remove(product) {
            if (this._products.length === 0) {
                throw new Error("ShoppigCart is empty.");
            }
            if (product instanceof Product) {
                let position;
                for (let i = 0; i < this._products.length; i += 1) {
                    let currentProduct = this._products[i];
                    if (currentProduct.name === product.name && currentProduct.productType === product.productType && currentProduct.price === product.price) {
                        position = i;
                        break;
                    }
                }

                if (position !== undefined) {
                    this._products.splice(position, 1);
                } else {
                    throw new Error("No such product in the shopping cart.");
                }
            }
        }

        showCost() {
            let cost = 0;

            for (let product of this._products) {
                cost += product.price;
            }

            return cost;
        }

        showProductTypes() {
            let productTypes = [];

            for (let product of this._products) {

                let currentProductType = product.productType;
                let isContainType = productTypes.indexOf(currentProductType);

                if (isContainType < 0) {
                    productTypes.push(currentProductType);
                }
            }

            productTypes.sort(function(a, b) {
                if (a < b) {
                    return -1;
                } else {
                    return 1;
                }

            });

            return productTypes;
        }

        getInfo() {

            if (this._products.length === 0) {
                return {
                    products: [],
                    totalPrice: 0
                };
            } else {
                let cart = {
                    products: [],
                    totalPrice: 0
                };

                cart.totalPrice = this.showCost();

                for (let product of this._products) {
                    let currentName = product.name;

                    let isContain = false;

                    for (let name of cart.products) {
                        if (name.name === currentName) {
                            isContain = true;
                        }
                    }

                    if (isContain) {
                        cart.products.quantity += 1;
                        cart.products.totalPrice += product.price;
                    } else {
                        let current = { name: product.name, totalPrice: product.totalPrice, quantity: 1 };

                        cart.products.push(current);
                    }
                }
                return cart;
            }
        }

    }
    return {
        Product,
        ShoppingCart
    };
}

module.exports = solve;