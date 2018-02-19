
#ifndef OPENCV_FLANN_DUMMY_H_
#define OPENCV_FLANN_DUMMY_H_

namespace cvflann
{

#if (defined WIN32 || defined false || defined WINCE) && defined CVAPI_EXPORTS
__declspec(dllexport)
#endif
void dummyfunc();

}


#endif  /* OPENCV_FLANN_DUMMY_H_ */
