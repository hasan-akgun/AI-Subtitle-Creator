using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Subtitle_AI.ViewModels
{
    class MainView : ViewBase
    {
        private string filePath = "No file choosen";
        public string FilePath { 
            get { return filePath; } 
            set {
                filePath = value;
                OnPropertyChanged();
            } 
        }
        public ICommand ChooseFileCommand { get; }

        public MainView()
        {
            ChooseFileCommand = new RelayCommand(ChooseFile);
        }

        private void ChooseFile()
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Media Files |*.mp4;*.mkv;*.avi;*.mov;*.wav;*.mp3|Video Files|*.mp4;*.mkv;*.avi;*.mov|Sound Files|*.wav;*.mp3";
            if(dialog.ShowDialog() == true)
            {
                FilePath = dialog.FileName;
            }
        }

    }
}
