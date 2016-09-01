'use strict';

function solve() {
    var library = (function() {
        var books = [];
        var categories = [];

        function listBooks() {

            books.sort(function(firstBook, secondBook) {
                return firstBook.Id - secondBook.ID;
            });

            return books;
        }

        function addBook(book) {
            book.ID = books.length + 1;

            isBookInfoValid(book);

            if (!isCategoryExist(book.Category)) {
                categories.push(book.Category);
            }

            books.push(book);

            return book;
        }

        function listCategories() {

            if (categories.length === 0) {
                throw new Error("Error");
            }

            categories.sort(function(firstCategory, secondCategory) {
                return firstCategory.ID - secondCategory.ID;
            });

            return categories;
        }

        function isCategoryExist(category) {
            categories.forEach((currentCategory) => {
                if (currentCategory === category) {
                    return false;
                }

                return true;
            });
        }

        function isBookInfoValid(book) {

            // if (book.isbn.length !== 10 || book.isbn.length !== 13) {
            //     throw new Error("Error");
            // }

            // if (book.author.length === 0) {
            //     throw new Error("Error");
            // }

            // if (book.title.length < 3 || book.title.length > 100) {
            //     throw new Error("Error");
            // }

            // if (!isStringContainsValidSymbols(book.title)) {
            //     throw new Error("Error");
            // }

            // if (book.category.length < 3 || book.category.length > 100) {
            //     throw new Error("Error");
            // }

            // if (!isStringContainsValidSymbols(book.category)) {
            //     throw new Error("Error");
            // }

            // if (!isBookIsbnUnique(book.isbn)) {
            //     throw new Error("Error");
            // }

            // if (!isBookTitleUniqe(book.title)) {
            //     throw new Error("Error");
            // }
            let isBookIsbnLengthValid = book.isbn.length === 10 || book.isbn.length === 13;
            let isBookAuthorValid = book.author.length !== 0;
            let isBookTitleLengthValid = isStringLengthValid(book.title.length);
            let isBookTitleSymbolsValid = isStringContainsValidSymbols(book.title);
            let isBookCategoryLengthValid = isStringLengthValid(book.category.length);
            let isBookCategorySymbolsValid = isStringContainsValidSymbols(book.category);
            let isIsbnUnique = isBookIsbnUnique(book.isbn);
            let isTitleUnique = isBookTitleUniqe(book.title);

            if (isBookIsbnLengthValid && isBookAuthorValid &&
                isBookTitleLengthValid && isBookTitleSymbolsValid &&
                isBookCategoryLengthValid && isBookCategorySymbolsValid &&
                isIsbnUnique && isTitleUnique) {
                return true;
            } else {
                return false;
            }

            // return true;
        }

        function isBookTitleUniqe(title) {
            books.forEach(book => {
                if (book.Title === title) {
                    return false;
                }

                return true;
            });
        }

        function isBookIsbnUnique(isbn) {
            books.forEach(book => {
                if (book.isbn === isbn) {
                    return false;
                }

                return true;
            });
        }

        function isStringLengthValid(input) {
            let isLengthValid = input > 2 && input < 100;

            return isLengthValid;
        }

        function isStringContainsValidSymbols(input) {
            let validSymbols = /^[0-9a-zA-Z]+$/;
            if (input.match(validSymbols)) {
                return true;
            } else {
                return false;
            }
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}

// console.log(solve().addBook({
//     title: 'B',
//     isbn: '1234567890',
//     author: 'John Doe',
//     category: 'Book Category'
// }));

// var f = solve();
// console.log(f.addBook({
//     title: 'B',
//     isbn: '1234567890',
//     author: 'John Doe',
//     category: 'Book Category'
// }));

module.exports = solve;