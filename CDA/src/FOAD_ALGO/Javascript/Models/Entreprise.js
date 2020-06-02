const Employee = require('./Employee.js');

/**
 * Gestion d'employés
 */
class Enterprise {
    constructor() {
        this.employees = [];
    }

    /**
     * 
     * @param  _filter 
     */
    readAll() {
        return this.employees;
    }


    /**
     * Créer un employé
     * @param Employee _employee 
     */
    create(_employee) {
        this.employees.push(_employee);
    }

    /**
     * 
     * @param int _id 
     */
    read(_id) {
        for (let i = 0; i < this.employees.length; i++) {
            if (this.employees[i].id == _id) {
                return this.employees[i];
                break;
            }
        }
    }

    /**
     * Met à jour un employé
     * @param Employee _employee 
     */
    update(_employee, _new, _change) {
        switch (_change) {
            case "lastname":
                return _employee.lastname=_new ;
            case "firstname":
                return _employee.firstname=_new;
            case "role":
                return _employee.role=_new;
            case "salary":
                return _employee.salarye=_new;
            case "hiredate":
                return _employee.hiredate=_new;
            case "email":
                return _employee.emaile=_new;
            default:
                return _employee.id=_new;

        }
    }
    /**
     * Supprime un employé
     * @param int _id 
     */
    delete(_id) {
        for (let i = 0; i < this.employees.length; i++) {
            if (this.employees[i].id == _id) {
                this.employees.splice(i, 1);
                break;

            }
        }

    }

    /**
     * Augmentation du salaire
     */
    getHigherSalary(_employee, _newSalary) {
        if (_newSalary > _employee.salary) {
            _employee.salary = _newSalary;
        }
    }

    /**
     * Diminution du salaire
     */
    getLowerSalary(_employee, _newSalary) {
        if (_newSalary < _employee.salary) {
            _employee.salary = _newSalary;
        }
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

