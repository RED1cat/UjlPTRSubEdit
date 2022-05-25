using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ujl_subedit
{
    class FileInfo
    {
        private string filePathToSave = null;
        private string fileName = "file";
        private bool fileRegionUsa = false;
        private bool fileRegionEurope = false;
        private string fileInformation = "info";
        private int[] fileSubLengthEurope = new int[5];
        private int fileSubLengthEuropeAll = 0;
        private int fileSubLengthUsa = 0;
        private byte[] fileBytes;
        private bool fileHasEdited = false;

        public string FilePathToSave
        {
            get
            {
                return filePathToSave;
            }
            set
            {
                filePathToSave = value;
            }
        }
        public string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                fileName = value;
            }
        }
        public bool FileRegionUsa
        {
            get
            {
                return fileRegionUsa;
            }
            set
            {
                fileRegionUsa = value;
            }
        }
        public bool FileRegionEurope
        {
            get
            {
                return fileRegionEurope;
            }
            set
            {
                fileRegionEurope = value;
            }
        }
        public string FileInformation
        {
            get
            {
                return fileInformation;
            }
            set
            {
                fileInformation = value;
            }
        }
        public int FileSubLengthUsa
        {
            get
            {
                if(FileRegionUsa == true)
                {
                    return fileSubLengthUsa;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if(FileRegionUsa == true)
                {
                    fileSubLengthUsa = value;
                }
                else
                {
                    fileSubLengthUsa = 0;
                }
            }
        }
        public int[] FileSubLengthEurope
        {
            get
            {
                if(FileRegionEurope == true)
                {
                    return fileSubLengthEurope;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if(FileRegionEurope == true)
                {
                    fileSubLengthEurope = value;
                }
                else
                {
                    fileSubLengthEurope = null;
                }
            }
        }
        public int FileSubLengthEuropeAll
        {
            get
            {
                return fileSubLengthEuropeAll;
            }
            set
            {
                fileSubLengthEuropeAll = value;
            }
        }
        public byte[] FileBytes
        {
            get
            {
                return fileBytes;
            }
            set
            {
                fileBytes = value;
            }
        }
        public bool FileHasEdited
        {
            get
            {
                return fileHasEdited;
            }
            set
            {
                fileHasEdited = value;
            }
        }

        public FileInfo(string name, string region)
        {
            FileName = name;

            if(region == "usa")
            {
                FileRegionUsa = true;
            }
            else if(region == "europe")
            {
                FileRegionEurope = true;
            }
            else
            {
                throw new Exception("region not set");
            }

            if(FileRegionUsa == true)
            {
                FileSubLengthUsa = Editor.m_XDocUjlUsa.GetXmlNode(name, "usa", "GetsubTitleNode").ChildNodes.Count;
                FileInformation = Editor.m_XDocUjlUsa.GetXmlNode(name, region, "GetfileInfoNode").InnerText + " - " + region;
            }
            else if(fileRegionEurope == true)
            {
                FileInformation = Editor.m_XDocUjlEurope.GetXmlNode(name, region, "GetfileInfoNode").InnerText + " - " + region;

                int[] subTitleCountEur = new int[5];
                int subTitleCountEurAll = 0;
                for (int i = 0; i < 5; i++)
                {
                    subTitleCountEur[i] = Editor.m_XDocUjlEurope.GetXmlNode(fileName, "europe", "GetsubTitleNodeById", id: i + 1).ChildNodes.Count;
                    subTitleCountEurAll += subTitleCountEur[i];
                }
                FileSubLengthEurope = subTitleCountEur;
                FileSubLengthEuropeAll = subTitleCountEurAll;
            }

        }
    }
}
