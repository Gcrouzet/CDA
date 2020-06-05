const Employee = require('./Employee.js');

/**
 * Gestion d'employés
 */
class Enterprise {
    constructor() {
        this.employees = [];
    }
    /**
     * Valide un objet Employee
     * @param Employee _employee
     */
    isValid(_employee) {

        if (!(_employee instanceof Employee)) {
            return false;
        }
        return true;
    }
    /**
     * 
     * @param  _filter 
     */
    readAll(_filter) {
        return this.employees.filter(_filter);
    }


    /**
     * Créer un employé (valide les données de l'employé et l'ajoute à la collection)
     * @param Employee _employee 
     * @returns Employee L'objet Employee ajouté
     */
    create(_employee) {

        if (this.isValid(_employee)) {
            this.employees.push(_employee);
        }

        return _employee;
    }


    /**
     * 
     * @param int _id 
     */
    read(_id) {
       
        let emp = this.employees.find(emp => emp.id === parseInt(_id));

        if (emp !== undefined) {
        let copie = Object.assign(new Employee(), emp);
        return copie ;
        }

        return undefined;
    }
    
    /**
     * Met à jour un employé
     * @param Employee _employee 
     */
    update(_employee) {
        if (!this.isValid(_employee)) {
            return _employee;
        }
        if (_employee.id < 1 && _employee.id !== NaN) {
            return _employee;
        }
        let exists = this.read(_employee.id);
        if (exists !== undefined && exists === _employee) {

        }
        return _employee;
    }
    /**
     * Supprime un employé
     * @param int _id 
     */
    delete(_id) {
        let index = this.employees.findIndex(emp => emp.id === parseInt(_id));
        this.employees.splice(index, 1);
    }



    /**
     *
     */
    getHighestSalary() {
        this.employees.sort(function (a, b) {
            return b.salary - a.salary;
        });
        let higestSalary = this.employees[0];
        return higestSalary;
    }
    /**
     * 
     */
    getLowestSalary() {
        this.employees.sort(function (a, b) {
            return a.salary - b.salary;
        });
        let lowestSalary = this.employees[0];
        return lowestSalary;
    }

    /**
     * 
     */
    getSalaryGap(_employeeA, _employeeB) {
        let diff;
        if (_employeeA.salary == _employeeB.salary) {
            return "Ces deux employés perçoivent le même salaire";
        }
        if (_employeeA.salary > _employeeB.salary) {
            diff = _employeeA.salary - _employeeB.salary;
            return _employeeA.firstname + " perçoit " + diff + "€/an de plus que " + _employeeB.firstname;
        }
        if (_employeeB.salary > _employeeA.salary) {
            diff = _employeeB.salary - _employeeA.salary;
            return _employeeB.firstname + " perçoit " + diff + "€/an de plus que " + _employeeA.firstname;
        }
    }



}


module.exports = Enterprise;

