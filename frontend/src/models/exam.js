app.factory("ExamModel", function ($http) {
  return {
    getExamById: function (id) {
      // $http({
      //     method: 'GET',
      //     url: '/someUrl'
      //   }).then(function successCallback(response) {
      //       // this callback will be called asynchronously
      //       // when the response is available
      //     }, function errorCallback(response) {
      //       // called asynchronously if an error occurs
      //       // or server returns response with an error status.
      //     });

      return true;
    },
    getExams: function () {
      return exams;
    },
    registerExam: function () {
      return true;
    }
  };
});