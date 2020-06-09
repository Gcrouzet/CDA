const fs = require('fs');
const path = require('path');
const Employee = require('./Employee.js');

/**
 * Gestion d'employés
 */
class Enterprise {
    constructor(_name) {
        this.name = _name || "CRM";
        this.filename = path.resolve(__dirname, "../data/" + _name + ".json");
        this.employees = [];
        if (fs.existsSync(this.filename)) {

            let raw = fs.readFileSync(this.filename); // lecture des données du fichier
            let json = JSON.parse(raw); // conversion du JSON en objet Javascript

            json.forEach(emp => {
                this.create(new Employee(emp));
            });
        }
        else {
            console.log(this.filename);
            console.log('fichier inexistant');
            fs.writeFileSync(this.filename, "[]"); // création du fichier. Le second paramètre est un tableau vide au format JSON.
        }
    }

    save() {
        let json = JSON.stringify(this.employees); // conversion de la collection d'employés vers le format JSON
        fs.writeFileSync(this.filename, json); // écriture des données JSON dans le fichier de sauvegarde
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

        if (this.isValid(_employee) && this.employees.find(e => e.id === _employee.id) === undefined) {
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
            return copie;
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

        // si l'identifiant est inférieur à 1 ou égal à "NaN" 
        if (_employee.id < 1 && _employee.id !== NaN) {
            return _employee;
        }

        let exists = this.employees.find(e => e.id === _employee.id); 

        if (exists !== undefined) {
            exists.copy(_employee);
            return exists;
        }

        return exists;
    }
    
    /**
     * Supprime un employé
     * @param int _id 
     */
    delete(_id) {
        let toDelete = this.employees.findIndex(emp => emp.id === parseInt(_id));
        if (toDelete > -1)
        this.employees.splice(toDelete, 1);
    }



    /**
     *
     */
    getHighestSalary() {
        return this.employees.sort((a, b) => b.salary - a.salary)[0];
    }
    /**
     * 
     */
    getLowestSalary() {
        return this.employees.sort((a, b) => a.salary - b.salary)[0];
    }

    /**
     * 
     */
    getSalaryGap() {
        return this.getHighestSalary().salary - this.getLowestSalary().salary;

    }

}


module.exports = Enterprise;

