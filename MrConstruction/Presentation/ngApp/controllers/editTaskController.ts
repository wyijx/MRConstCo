﻿namespace MrConstruction.Controllers {

    export class EditTaskController {

        public task;
        public selectedContractor;

        constructor(private $uibModalInstance, private $http: ng.IHttpService,
            private $location: ng.ILocationService, task) {
            this.task = task;
        }

        public ok(edittask) {
            this.$uibModalInstance.close(edittask);
        }

        public cancel() {
            this.$uibModalInstance.dismiss();
        }
    }
}