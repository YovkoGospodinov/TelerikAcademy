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

        return this;
    }

    get length() {
        return this._length;
    }

    get first() {
        return this._head.data;
    }

    get last() {
        if (this._head !== null) {
            let currentNextMember = this._head.next;
            let currentMember = this._head;
            while (currentNextMember !== null) {
                currentMember = currentNextMember;
                currentNextMember = currentMember.next;
            }
            return currentMember.data;
        } else {
            return this._head.data;
        }
    }

    append(...items) {
        for (const item of items) {
            let currentMember = new listNode(item);
            if (this._head !== null) {
                this.atIndex(this.length - 1).next = currentMember;
            } else {
                this._head = currentMember;
            }
            this._length += 1;
        }

        return this;
    }

    prepend(...items) {
        for (let i = items.length - 1; i >= 0; i -= 1) {
            let memberToAdd = new listNode(items[i]);
            if (this._head !== null) {
                let headItem = this._head;
                this._head = memberToAdd;
                this._head.next = headItem;
            } else {
                this._head = memberToAdd;
            }

            this._length += 1;
        }

        return this;
    }

    at(index, item) {
        if (item === undefined) {
            let itemAtIndex = this._head;
            for (let i = 0; i < index; i += 1) {
                itemAtIndex = itemAtIndex.next;
            }

            return itemAtIndex.data;
        } else {
            this.insert(index, item);
            this.removeAtIndex(index + 1);
        }
    }

    atIndex(index, item) {
        if (item === undefined) {
            let itemAtIndex = this._head;
            for (let i = 0; i < index; i += 1) {
                itemAtIndex = itemAtIndex.next;
            }

            return itemAtIndex;
        } else {
            this.insert(index, item);
            this.removeAtIndex(index + 1);
        }
    }

    insert(index, ...items) {
        for (let i = items.length - 1; i >= 0; i -= 1) {
            let itemAtIndex = this.atIndex(index);
            if (index === 0) {
                this._head = new listNode(items[i]);
                this._head.next = itemAtIndex;
            } else {
                this.atIndex(index - 1).next = new listNode(items[i]);
                this.atIndex(index).next = itemAtIndex;
            }


            this._length += 1;
        }

        return this;
    }

    removeAt(index) {
        let removedMember;
        if (index !== 0) {
            removedMember = this.atIndex(index);
            this.atIndex(index - 1).next = this.atIndex(index + 1);
        } else {
            removedMember = this._head;
            this._head = removedMember.next;
        }

        this._length -= 1;

        return removedMember.data;
    }

    removeAtIndex(index) {
        let removedMember;
        if (index !== 0) {
            removedMember = this.atIndex(index);
            this.atIndex(index - 1).next = this.atIndex(index + 1);
        } else {
            removedMember = this._head;
            this._head = removedMember.next;
        }

        this._length -= 1;

        return removedMember;
    }

    [Symbol.iterator]() {
        let currentMember = this._head;

        return {
            i: 0,
            next() {
                if (currentMember) {
                    this.i += 1;
                    let temp = currentMember;
                    currentMember = currentMember.next;

                    return {
                        value: temp.data,
                        done: false
                    };
                } else {
                    return {
                        value: undefined,
                        done: true
                    };
                }
            }
        };
    }

    toArray() {
        let array = [];
        let currentMember = this._head;
        array.push(currentMember.data);
        while (currentMember.next) {
            currentMember = currentMember.next;
            array.push(currentMember.data);
        }
        return array;
    }

    toString() {
        return this.toArray().join(' -> ');
    }
}

module.exports = LinkedList;