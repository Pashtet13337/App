using System.Threading;
using System.Threading.Tasks;
using ITHUBApp.DAL.DataObjects;

namespace ITHUBApp.DAL.DataServices.Mock {
	class MockMainDataService: BaseMockDataService, IMainDataService {
		public Task<RequestResult<SampleDataObject>> GetSampleDataObject(CancellationToken ctx) {
			return GetMockData<SampleDataObject>("ITHUBApp.DAL.Resources.Mock.Main.SampleDataObject.json");
		}
	}
}



