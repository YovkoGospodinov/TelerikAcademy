'use strict';

class listNode {
    constructor(value) {
        this._data = value;
        this._next = null;
    }

    get data() {
        return this._data;
    }

    get next() {
        return this._next;
    }

    set next(value) {
        this._next = value;
    }
}

class LinkedList {
    constructor() {
        this._head = null;
        this._length = 0;
    }

    get length() {
        return this._length;
    }

    get first() {
        return this._head;
    }

    get last() {
        if (this._head !== null) {
            let currentNextMember = this._head.next;
            let currentMember = this._head;
            while (currentNextMember !== null) {
                currentMember = currentNextMember;
                currentNextMember = currentMember.next;
            }
            return currentMember;
        } else {
            return this._head;
        }
    }

    append(items) {
        if (this._head !== null) {
            this.last.next = new listNode(items);
            this._length += 1;
        } else {
            this._head = new listNode(items);
            this._length += 1;
        }
    }

    preprend(items) {
        if (this._head !== null) {
            let headItem = this._head;
            this._head = new listNode(items);
            this._head._next = headItem;
            this._length += 1;
        } else {
            this._head = new listNode(items);
            this._length += 1;
        }
    }

    at(index, items) {
        if (items === undefined) {
            let itemAtIndex = this._head;
            for (let i = 0; i < index; i += 1) {
                itemAtIndex = itemAtIndex.next;
            }

            return itemAtIndex;
        } else {
            this.insert(index, items);
            this.removeAt(index + 1);
        }
    }

    insert(index, items) {
        let itemAtIndex = this.at(index);
        this.at(index - 1).next = new listNode(items);
        this.at(index).next = itemAtIndex;
        this._length += 1;
    }

    removeAt(index) {
        this.at(index - 1).next = this.at(index + 1);
        this._length -= 1;
    }

    [Symbol.iterator]() {

    }

    toArray() {
        let array = [];
        let currentMember = this._head;
        array.push(currentMember);
        for (let i = 0; i < this._length; i += 1) {
            currentMember = currentMember.next;
            array.push(currentMember);
        }
        return array;
    }

    toString() {
        let result = "";
        for (let i = 0; i < this._length; i += 1) {
            if (i != this._length - 1) {
                result += `${this.at(i).data} -> `;
            } else {
                result += `${this.at(i).data}`;
            }
        }

        return result;
    }
}


// let set = new LinkedList();
// set.append(5);
// set.append(10);
// set.append(15);

// console.log(set.toString());


module.exports = LinkedList;